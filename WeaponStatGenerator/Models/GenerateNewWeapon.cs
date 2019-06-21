namespace WeaponStatGenerator.Models
{
    public interface IGenerateNewWeapon
    {
        Weapon Generate(WeaponArchType weaponArchType);
    }

    public class GenerateNewWeapon : IGenerateNewWeapon
    {
        private readonly IGenerateDamageType _generateDamageType;
        private readonly IGenerateDamageStat _generateDamageStat;
        private readonly IGenerateWeaponName _generateWeaponName;

        public GenerateNewWeapon(
            IGenerateWeaponName generateWeaponName,
            IGenerateDamageType generateDamageType,
            IGenerateDamageStat generateDamageStat)
        {
            _generateDamageType = generateDamageType;
            _generateDamageStat = generateDamageStat;
            _generateWeaponName = generateWeaponName;
        }

        public Weapon Generate(WeaponArchType weaponArchType) =>
            new Weapon(
                _generateWeaponName.Generate(),
                weaponArchType,
                _generateDamageStat.Generate(),
                _generateDamageType.Generate());
    }
}