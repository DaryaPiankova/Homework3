Console.Clear();
Console.WriteLine("Введите пятизначное число");
string a=Console.ReadLine();
int count=0;
for(int i=0; i<(a.Length/2); i++){
    if(a[i]!=a[a.Length-i-1]){
       count++;        
    }
}
if(count==0){
    Console.WriteLine("Да");
}else{
    Console.WriteLine("Нет");
}