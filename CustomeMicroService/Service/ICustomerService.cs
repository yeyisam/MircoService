﻿namespace CustomeMicroService.Service
{
    public interface ICustomerService
    {
        Task<decimal> UpdateScore(long customerId, decimal scoreGap);

        Task<IEnumerable<LeaderBoard>> GetCustomersByRank(int startRank, int endRank);

        Task<List<LeaderBoard>> GetCustomersById(long customerId, int highRank = 0, int lowRank = 0);
    }
}
