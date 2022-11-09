namespace ENSPRONET.Services.Services.Common.Interfaces;

public interface ISeederService<T> where T : class
{
    IEnumerable<T> GenerateSeedData(int numberRecords);
}
