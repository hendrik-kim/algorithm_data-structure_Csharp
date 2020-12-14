using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_DataStructure_Csharp
{
    class MaxProfit
    {
        // brute force
        public int MaxProfitSln(int[] prices)
        {
            int maxProfit = 0;

            for(int i=0; i<prices.Length; i++)
            {
                for(int j=0; j<prices.Length; j++)
                {
                    int profit = prices[j] - prices[i];
                    if(maxProfit < profit)
                    {
                        maxProfit = profit;
                    }
                }
            }

            return maxProfit;
        }
    }
}
