using System;
using System.ComponentModel;
using System.IO;
using System.Xml;
using Size = System.Drawing.Size;

namespace GTSettings
{
    public class Eyetracker : INotifyPropertyChanged
    {
        #region Constants

        public const string Name = "EyetrackerSettings";

        #endregion

        #region Variables

        //private HaarCascade haarCascade;
        private string haarCascadePath;
        private string defaultHaarCascadePath = Directory.GetCurrentDirectory() + "\\" + "haarcascade_eye.xml";
        private double scaleFactor = 4; // originally 1.1, 4 is faster 
        private double scaleFactorDefault = 1.2;

        private Size sizeMax = new Size(200, 200);
        private Size sizeMin = new Size(30, 30); // size that the detector was trained on, 30x30 for the standard eye classifier


        #endregion

        #region Events 

        #region Delegates

        public delegate void HaarcascadeChangeHandler(bool success);

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        public event HaarcascadeChangeHandler OnHaarCascadeLoaded;

        #endregion

        #region Get/Set

        public string HaarCascadePath
        {
            get
            {
                if (haarCascadePath == null)
                    return defaultHaarCascadePath;

                return haarCascadePath;
            }
            set
            {
                haarCascadePath = value;
                OnPropertyChanged("HaarCascadePath");
            }
        }


        public Size SizeMin
        {
            get { return sizeMin; }
            set
            {
                sizeMin = value;
                OnPropertyChanged("SizeMin");
            }
        }

        public Size SizeMax
        {
            get { return sizeMax; }
            set
            {
                sizeMax = value;
                OnPropertyChanged("SizeMax");
            }
        }

        public double ScaleFactor
        {
            get { return scaleFactor; }
            set
            {
                scaleFactor = value;
                OnPropertyChanged("ScaleFactor");
            }
        }

        public double ScaleFactorDefault
        {
            get { return scaleFactorDefault; }
            set { scaleFactorDefault = value; }
        }

        #endregion

        #region Public Methods - Read/Write/encode configuration files 

        public void WriteConfigFile(XmlTextWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("EyetrackerSettings");

            Settings.WriteElement(xmlWriter, "HaarCascadePath", HaarCascadePath);
            Settings.WriteElement(xmlWriter, "SizeMin", SizeMin.Width.ToString());
            Settings.WriteElement(xmlWriter, "SizeMax", SizeMax.Width.ToString());
            Settings.WriteElement(xmlWriter, "ScaleFactor", ScaleFactor.ToString());

            xmlWriter.WriteEndElement();
        }

        public void LoadConfigFile(XmlReader xmlReader)
        {
            string sName = "";

            while (xmlReader.Read())
            {
                switch (xmlReader.NodeType)
                {
                    case XmlNodeType.Element:
                        sName = xmlReader.Name;
                        break;
                    case XmlNodeType.Text:
                        switch (sName)
                        {
                            case "HaarCascadePath":
                                HaarCascadePath = xmlReader.Value;
                                break;
                            case "SizeMin":
                                int min = int.Parse(xmlReader.Value);
                                SizeMin = new Size(min, min);
                                break;
                            case "SizeMax":
                                int max = int.Parse(xmlReader.Value);
                                SizeMax = new Size(max, max);
                                break;
                            case "ScaleFactor":
                                ScaleFactor = double.Parse(xmlReader.Value);
                                break;
                        }
                        break;
                }
            }
        }

        public string SettingsEncodeString()
        {
            string sep = ",";
            string str = "";

            //str += "Brightness=" + Brightness.ToString() + sep;
            //str += "Contrast=" + Contrast.ToString() + sep;
            //str += "Saturation=" + Saturation.ToString() + sep;
            //str += "Sharpness=" + Sharpness.ToString() + sep;
            //str += "Zoom=" + Zoom.ToString() + sep;
            //str += "Focus=" + Focus.ToString() + sep;
            //str += "Exposure=" + Exposure.ToString() + sep;
            //str += "FlipImage=" + FlipImage.ToString();

            return str;
        }

        public void ExtractParametersFromString(string parameterStr)
        {
            //try
            //{
            //    // Seperating commands
            //    char[] sepParam = { ',' };
            //    string[] camParams = parameterStr.Split(sepParam, 20);

            //    // Seperating values/parameters
            //    char[] sepValues = { '=' };

            //    for (int i = 0; i < camParams.Length; i++)
            //    {
            //        string[] cmdString = camParams[i].Split(sepValues, 5);
            //        string subCmdStr = cmdString[0];
            //        string value = cmdString[1];

            //        switch (subCmdStr)
            //        {
            //            case "Brightness":
            //                this.Brightness = int.Parse(value);
            //                break;
            //            case "Contrast":
            //                this.Contrast = int.Parse(value);
            //                break;
            //            case "Saturation":
            //                this.Saturation = int.Parse(value);
            //                break;
            //            case "Sharpness":
            //                this.Sharpness = int.Parse(value);
            //                break;
            //            case "Zoom":
            //                this.Zoom = int.Parse(value);
            //                break;
            //            case "Focus":
            //                this.Focus = int.Parse(value);
            //                break;
            //            case "Exposure":
            //                this.Exposure = int.Parse(value);
            //                break;
            //            case "FlipImage":
            //                this.FlipImage = bool.Parse(value);
            //                break;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //}
        }

        public void LoadHaarCascade(string filepath)
        {
            if (File.Exists(filepath) == false)
            {
                //MessageBox.Show("Unable to find the haar cascade XML file: " + filepath);
                return;
            }

            try
            {
               // haarCascade = new HaarCascade(filepath);
                haarCascadePath = filepath;

                if (OnHaarCascadeLoaded != null)
                    OnHaarCascadeLoaded(true);
            }
            catch (Exception ex)
            {
                if (OnHaarCascadeLoaded != null)
                    OnHaarCascadeLoaded(false);

               // ErrorLogger.ProcessException(ex, true);
            }
        }

        #endregion

        #region Eventhandler

        private void OnPropertyChanged(string parameter)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(parameter));
            }
        }

        #endregion //EVENTHANDLER
    }
}