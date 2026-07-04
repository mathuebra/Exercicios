#include <iostream>
#include <vector>

using namespace std;

class Solution {
public:
    int maxProfit(vector<int>& prices) {
        int min_price = __INT_MAX__;
        int max_profit = 0;
        int n = prices.size();
        
        for (int i = 0; i < n; i ++)
        {
            if (prices[i] < min_price)
                min_price = prices[i];
            else 
                max_profit = max(max_profit, prices[i] - min_price);
        }

        return max_profit;
    }
};