int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if(a==b) { sum = a; }
            else { 
            if (a > b)
            {
                for (int i = b+1; i < a; i++)
                {
                    sum += i;
                }

            }
            else
            {
                for (int i = a+1; i < b; i++)
                {
                    sum += i;
                }
            }
            }
            Console.WriteLine($"sum={sum}");