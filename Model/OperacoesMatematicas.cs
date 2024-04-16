class OperacoesMatematicas(int num1, int num2)
{
    private int Num1 { get; set; } = num1;
    private int Num2 { get; set; } = num2;

    public int Somar(){
        return this.Num1 + this.Num2;
    }
    public int Subtrair(){
        return this.Num1 - this.Num2;
    }
    public int Multiplicar(){
        return this.Num1 * this.Num2;
    }
    public int Dividir(){
        return this.Num1 / this.Num2;
    }
}