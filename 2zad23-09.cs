using System;

class Program
{
    static void Main() {
         Console.WriteLine("������� ����� � ����������� (M):"); //��������� ������ ������������ ������ ���������� ������������� ����
         double M = Double.Parse(Console.ReadLine()); //� ��������� ������� ������
         double m;//��������� ������ ���������� ������������� ����
         m = Math.(M / 1000); //��������� ��������� �������� �������� ������
         Console.WriteLine($"���������� ������ ���� ����� {m}"); //����� ����������
    }     
}    
