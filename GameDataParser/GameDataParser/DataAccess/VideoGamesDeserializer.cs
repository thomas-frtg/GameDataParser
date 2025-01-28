using System.Text.Json;

public class VideoGamesDeserializer : IVideoGamesDeserializer
{
    private readonly IUserInteractor _userInteractor;

    public VideoGamesDeserializer(IUserInteractor userInteractor)
    {
        _userInteractor = userInteractor;
    }

    public List<VideoGame> DeserializeFrom(string fileName, string fileContent)
    {
        try
        {
            return JsonSerializer.Deserialize<List<VideoGame>>(fileContent);
        }
        catch (JsonException ex)
        {
            _userInteractor.PrintErrorMessage($"JSON in {fileName} was not" +
                $"in a valid format. JSON body:");
            _userInteractor.PrintErrorMessage(fileContent);

            throw new JsonException($"{ex.Message} The file is {fileName}", ex);
        }
    }
}
