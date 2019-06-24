using System;

namespace WeaponStatGenerator.Models
{
    public interface IGenerateDamageStat
    {
        int Generate();
    }

    public class GenerateDamageStat : IGenerateDamageStat
    {
        private const int maxDamageValue = 200;
        private const int minDamageValue = 50;
        private readonly Random _random = new Random();

        public int Generate() => _random.Next(minDamageValue, maxDamageValue);
    }
}