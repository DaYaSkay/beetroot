int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (a > b)
            {
                for (int i = b; i <= a; i++)
                {
                    sum += i;
                }

            }
            else
            {
                for (int i = a; i <= b; i++)
                {
                    sum += i;
                }
            }
            Console.Write(sum);