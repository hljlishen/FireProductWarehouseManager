using System.IO;
using System.Windows.Forms;

namespace FireProductManager.ServiceLogicPackage
{
    class ImageManager
    {
        private OpenFileDialog _openfiledialog = new OpenFileDialog();

        //获取浏览图片路径
        public string GetBrowseImagePath()
        {
            _openfiledialog.Filter = "All Image Files|*.bmp;*.ico;*.gif;*.jpeg;*.jpg;*.png;*.tif;*.tiff";
            if (_openfiledialog.ShowDialog() == DialogResult.OK)
            {
                string path = _openfiledialog.FileName;//你选中的图片的绝对路径
                return path;
            }
            return "";
        }

        //保存仪器图片
        public void SaveInstrumentImage(string tagId)
        {
            string folderPath = Directory.GetCurrentDirectory() + "/image/InstrumentPhoto/";
            SaveImage(tagId ,folderPath);
        }

        //保存员工图片
        public void SaveEmployeeImage(string employeeNumber)
        {
            string folderPath = Directory.GetCurrentDirectory() + "/image/EmployeePhoto/";
            SaveImage(employeeNumber, folderPath);
        }

        //保存图片
        private void SaveImage(string imageName,string folderPath)
        {
            string path = _openfiledialog.FileName;
            if (path.Equals("")) return;
            //判断是否有该路径  
            if (!Directory.Exists(folderPath))
            {   //如果不存在就创建
                Directory.CreateDirectory(folderPath);
                File.Copy(path, folderPath + imageName+".jpg");
            }
            else
            {
                FileInfo file = new FileInfo(folderPath + imageName + ".jpg");
                bool a = file.Exists;        //文件是否存在
                if (!file.Exists)
                {
                    File.Copy(path, folderPath + imageName + ".jpg");
                    return;
                }
                File.Delete(folderPath + imageName + ".jpg");
                File.Copy(path, folderPath + imageName + ".jpg");
            }
        }

        //获取仪器照片地址
        public string GetInstrumentPhotoPath(string tagId)
        {
            string instrumentPhotoPath;
            string imagePath = Application.StartupPath + @"\image\InstrumentPhoto\" + tagId + ".jpg";
            if (File.Exists(imagePath))
            {
                instrumentPhotoPath = Application.StartupPath + @"\image\InstrumentPhoto\" + tagId + ".jpg";
            }
            else
            {
                instrumentPhotoPath = DefualtInstrumentImagePath;
            }
            return instrumentPhotoPath;
        }

        //获取员工照片地址
        public string GetEmployeeImagePath(string employeeNumber)
        {
            string employeePhotoPath;
            string imagePath = Application.StartupPath + @"\image\EmployeePhoto\" + employeeNumber + ".jpg";
            //FileInfo filepath = new FileInfo(Application.StartupPath + @"\image\EmployeePhoto\" + imageName + ".jpg");
            if (File.Exists(imagePath))
            {
                employeePhotoPath = Application.StartupPath + @"\image\EmployeePhoto\" + employeeNumber + ".jpg";
            }
            else
            {
                employeePhotoPath = DefualtEmployeeImagePath;
            }
            return employeePhotoPath;
        }

        //获取默认仪器照片地址
        public string DefualtInstrumentImagePath
        {
            get => Application.StartupPath + @"\image\InstrumentPhoto\" + "仪器" + ".jpg";
        }

        //获取默认员工照片地址
        public string DefualtEmployeeImagePath
        {
            get => Application.StartupPath + @"\image\EmployeePhoto\" + "人员相片" + ".jpg";
        }

        //删除员工照片
        public void DeleteEmployeeImage(string tagId)
        {
            string employeePhotoPath;
            employeePhotoPath = Application.StartupPath + @"\image\EmployeePhoto\" + tagId + ".jpg";
            DeleteImage(employeePhotoPath);
        }

        //删除仪器照片
        public void DeleteInstrumentImage(string employeeNumber)
        {
            string instrumentPhotoPath;
            instrumentPhotoPath = Application.StartupPath + @"\image\InstrumentPhoto\" + employeeNumber + ".jpg";
            DeleteImage(instrumentPhotoPath);
        }

        //删除照片
        private void DeleteImage(string imagePath)
        {
            FileInfo file = new FileInfo(imagePath);
            if (!file.Exists)
            {
                return;
            }
            File.Delete(imagePath);
        }
    }
}
