/*
 * User: eneidler
 * Date: 06/13/2019
 * Time: 13:15
 *
 */

using System;
using System.Collections.Generic;

namespace WeaponStatGenerator.Models
{
    public interface IGenerateWeaponName
    {
        string Generate();
    }

    /// <summary>
    /// Generates random names for the weapons. Broken into two parts for more variety.
    /// Uses a weapon noun that will get concatenated with a descriptor. All collections
    /// and properties are private. Names are accessed through the GetRandomWeaponNoun()
    /// and GetRandomWeaponDescriptor() methods.
    /// </summary>
    public class GenerateWeaponName : IGenerateWeaponName
    {
        private readonly static IList<string> _availableWeaponNouns = new List<string>()
        {
            "Faith",
            "Hatred",
            "Epiphany",
            "Wish",
            "Cannon",
            "Handshake",
            "Cleaver",
            "Quake",
            "Hammer",
            "Sunder",
            "Breath"
        };

        private readonly static IList<string> _availableWeaponDescriptor = new List<string>()
        {
            "Destroying",
            "Equalizing",
            "Purifying",
            "Sanitizing",
            "Hopeful",
            "Elegant",
            "Unflinching",
            "Demolishing",
            "Shattering",
            "Imprisoning",
            "Unending",
            "Unyielding",
            "Broken"
        };

        private readonly Random _random = new Random();

        public string Generate() =>
            _availableWeaponNouns[_random.Next(0, _availableWeaponNouns.Count)]
            + " "
            + _availableWeaponDescriptor[_random.Next(0, _availableWeaponDescriptor.Count)];
    }
}