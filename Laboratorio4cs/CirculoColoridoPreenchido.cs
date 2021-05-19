using System.Drawing;

namespace Laboratorio4cs
{
    public class CirculoColoridoPreenchido : Circulo
    {
        public Color preenchimentoCor { get; set; }
        public CirculoColoridoPreenchido(double x, double y, double r, string c, Color p)
        : base(x, y, r)
        {
            this.preenchimentoCor = p;
        }
        public override string ToString()
        {
            return base.ToString() + $" preenchimento={preenchimentoCor}";
        }

    }
}