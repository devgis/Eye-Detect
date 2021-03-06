using GazeTrackingLibrary.Detection.BlobAnalysis;
using GazeTrackingLibrary.Utils;
using GTCommons.Enum;

namespace GazeTrackingLibrary.Detection.Pupil
{
    public class PupilData
    {
        public PupilData()
        {
            Eye = EyeEnum.Left;
            Center = new GTPoint();
            GrayCorners = new int[4];
        }

        public EyeEnum Eye { get; set; }

        public Blob Blob { get; set; }

        public GTPoint Center { get; set; }

        public int[] GrayCorners { get; set; }

        public double Area
        {
            get
            {
                if (Blob != null)
                    return Blob.Area;
                else
                    return 0;
            }
        }

        public double Diameter
        {
            get
            {
                if (Blob != null)
                    return (Blob.Rectangle.Width + Blob.Rectangle.Height)/2;
                else
                    return 0;
            }
        }
    }
}