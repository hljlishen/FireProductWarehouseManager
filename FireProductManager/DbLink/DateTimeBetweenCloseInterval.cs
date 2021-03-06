﻿using System;

namespace DbLink
{
    public class DateTimeBetweenCloseInterval : SelectCondition
    {
        private readonly DateTime? _begin;
        private readonly DateTime? _end;
        public IDateTimeFormater DateTimeFormater { get; set; }    //初始化之后应立即设置formater

        public DateTimeBetweenCloseInterval(string fieldName, DateTime? begin, DateTime? end, DatabaseType dbType) :base(fieldName)
        {
            _begin = begin;
            _end = end;
            DateTimeFormater = DbLinkGateway.CreateFactory(dbType).CreateDateTimeFormater();
        }

        protected override string MakeValidClause()
        {
            string begin = DateTimeFormater.DateTimeString(_begin);
            string end = DateTimeFormater.DateTimeString(_end);
            return $"{FieldName}>={begin} and {FieldName}<={end}";
        }

        public override bool IsValidCondition() => _begin != null && _end != null && DateTimeFormater != null;
    }
}