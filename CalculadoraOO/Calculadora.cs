namespace CalculadoraOO
{
    public class Calculadora
    {
        public double Operando1 { get; set; }
        public double Operando2 { get; set; }
        //sobrecarga de construtor;
        public Calculadora() { }
        public Calculadora(double operando1, Double operando2)
        {
            Operando1 = operando1;
            Operando2 = operando2;
        }
        //sobrescrita
        public override string ToString()
        {
            return "Operandos: " + Operando1 + ", " + Operando2;
        }
        public double Soma()
        {
            return Operando1 + Operando2;
        }
        //sobrecarga de metodo.
        public double Soma(double operando1, double operando2)
        {
            return operando1 + operando2;
        }
        public double Subtração()
        {
            return Operando1 - Operando2;
        }
        public double Subtração(double operando1, double operando2)
        {
            return operando1 + operando2;
        }
        public double Divisão()
        {
            return Operando1 / Operando2;
        }
        public double Divisão(double operando1, double operando2)
        {
            return operando1 + operando2;
        }
        public double Multiplicação()
        {
            return Operando1 * Operando2;
        }
        public double Multiplicação(double operando1, double operando2)
        {
            return operando1 + operando2;
        }
    }
}
