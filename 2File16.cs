using System;  
public class Exercise9  
{  
    public static void Main() 
{
    string str;
    int i, len, vowel;
	
      Console.Write("Enter the word : ");
      str = Console.ReadLine();		

    vowel = 0;
    len = str.Length;

    for(i=0; i<len; i++)
    {

        if(str[i] =='a' || str[i]=='e' || str[i]=='i' || str[i]=='o' || str[i]=='u' || str[i]=='A' || str[i]=='E' || str[i]=='I' || str[i]=='O' || str[i]=='U')
        {
            vowel++;
        }
        
    }
   Console.Write("\nThe total number of vowels in the word is : {0}\n", vowel);
   	}
}