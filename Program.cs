Console.Clear();
Console.WriteLine("Введите кол-во кустов на грядке");
int n = Convert.ToInt32(Console.ReadLine());
int maxSum=0;
for (int i=1; i<=n-2; i++){
    int sum=i+(i+1)+(i+2);
    if(sum>maxSum){
        maxSum=sum;
    }
}

Console.WriteLine(maxSum);
