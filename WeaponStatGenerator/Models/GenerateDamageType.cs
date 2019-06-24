using System;
using System.Collections.Generic;

namespace WeaponStatGenerator.Models
{
    public interface IGenerateDamageType
    {
        DamageType Generate();
    }

    public class GenerateDamageType : IGenerateDamageType
    {
        private static readonly IList<DamageType> _availableDamageTypes = ((DamageType[])Enum.GetValues(typeof(DamageType)));
        private readonly Random _random = new Random();

        public DamageType Generate() =>
            _availableDamageTypes[_random.Next(0, _availableDamageTypes.Count)];
    }
}