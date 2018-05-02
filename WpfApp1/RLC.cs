using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace WpfApp1 
{
    class RLC
    {
        private double _f;
        private double _R;
        private double _C;
        private Grid grid;

        public const int INDEX_F = 1;
        public const int INDEX_R = 5;
        public const int INDEX_C = 9;

        public enum TYPES
        {
            INDEX_F = 1,
            INDEX_R = 5,
            INDEX_C = 9,
        };

        public double F { get => _f; }
        public double R { get => _R; }
        public double C { get => _C; }

        public RLC(Grid grid)
        {
            this.grid = grid;
        }

        public void Initialize()
        {
            Exception ex = null;

            try
            {
                _f = getValue(TYPES.INDEX_F);
            }
            catch (InvalidValueException e)
            {
                _f = 0;
                setValueTB(TYPES.INDEX_F, 0);
                ex = e;
            }

            try
            {
                _R = getValue(TYPES.INDEX_R);
            }
            catch (InvalidValueException e)
            {
                _R = 0;
                setValueTB(TYPES.INDEX_R, 0);
                ex = e;
            }

            try
            {
                _C = getValue(TYPES.INDEX_C);
            }
            catch (InvalidValueException e)
            {
                _C = 0;
                setValueTB(TYPES.INDEX_C, 0);
                ex = e;
            }

            if (ex != null) throw new InvalidValueException("Invalid value", ex);
        }

        private double getValue(TYPES idx)
        {
            try
            {
                return Double.Parse((grid.Children[(int)idx] as TextBox).Text);
            }
            catch (Exception ex)
            {
                throw new InvalidValueException("Invalid value", ex);
            }
        }

        public void setValueTB(TYPES idx, double value)
        {
            (grid.Children[(int)idx] as TextBox).Text = value.ToString();
        }

        public double GetF()
        {
            // 1/(2piRC)
            return 1 / (2 * Math.PI * _R * _C);
        }

        public double GetR()
        {
            // 1/(2piRC)
            return 1 / (2 * Math.PI * _f * _C);
        }

        public double GetC()
        {
            Console.WriteLine(_f);
            Console.WriteLine(_R);
            // 1/(2piRC)
            return 1 / (2 * Math.PI * _f * _R);
        }
    }
}
