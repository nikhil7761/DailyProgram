namespace cross
{

public delegate void calcualtion(int a,int b);
class program
{
public static void addition(int a,int b){
int result=a+b;
Console.WriteLine("addition result is {0}",result);
}
public static void substraction(int a,int b){
int result=a-b;
Console.WriteLine("addition result is {0}",result);
}


public static void Main(String[] args)
{
calcualtion obj=new calcualtion(program.addition);
obj.Invoke(23,12);
obj=substraction;
obj(10,3);

}



}














}