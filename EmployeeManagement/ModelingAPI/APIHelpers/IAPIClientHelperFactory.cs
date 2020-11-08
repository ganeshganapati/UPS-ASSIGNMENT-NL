namespace ModelingAPI.APIHelpers
{
    public interface IAPIClientHelperFactory
    {
        APIHelper CreateHttpClient();
    }
}