using System;

public class Calculadora{
	public Calculadora(){

	}
	public double somar(double num1, double num2){
		return num2 + num1;
	}
    public double dividir(double num1, double num2){
        return num2 / num1;
    }
    public double diferenca (double num1, double num2)
    {   if (num1 > num2 ) return num1-num2;
        else if (num1 < num2) return num2-num1;
        else if (num2< 0  || num1<0) return num1-(num2);
      
    }
    public int restoDaDivisao(int num1, int num2) {
        return num1% num2;
    }
    public double coverterFloatForDouble(float num1) {
        double num2 = (double) num1;
        return num2;

    }
    public float coverterDoubleForFloat()
    {
        double n1 = 10.1;
        float n2 = (float)n1; 
        return n2;
    }
    public byte coverterIntForByte(int n1) {
        byte n2 = (byte)n1;
        return n2;
    }
    public int coverterByteForINT(byte n1) { byte n2 = (byte)n1; return n2 
    public int coverterCharForInt(char n1 ) { int n2 = (int)n1; return n2 }
}
