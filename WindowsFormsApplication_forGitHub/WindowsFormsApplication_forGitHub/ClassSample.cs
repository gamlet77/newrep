using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication_forGitHub
{
    /// <summary>
    /// Класс содержащий точку в 3d-пространстве
    /// </summary>
    public class Vertex3d
    {
        //поля
        private double _x;
        private double _y;
        private double _z;
        
        //свойства
        public double X
        {
            get { return _x; }
            set { _x = value; }
        }

        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public double Z
        {
            get { return _z; }
            set { _z = value; }
        }

        /// <summary>
        /// Метод, обнуляет все три координаты
        /// </summary>
        public void SetToOrigin()
        {
            X = Y = Z = 0;
        }
    }
}
