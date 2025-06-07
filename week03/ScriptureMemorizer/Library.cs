public class Library
{
    private List<Scripture> _scriptures;
    private Random _random;

    public Library()
    {
        _scriptures = new List<Scripture>();
        _random = new Random();

        _scriptures.Add(new Scripture(new Reference("1 Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."));
        _scriptures.Add(new Scripture(new Reference("Moroni", 10, 4), "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost."));
        _scriptures.Add(new Scripture(new Reference("D&C", 6, 36), "Look unto me in every thought; doubt not, fear not."));
        _scriptures.Add(new Scripture(new Reference("Jacob", 2, 18), "But before ye seek for riches, seek ye for the kingdom of God."));
        _scriptures.Add(new Scripture(new Reference("Jonh", 14, 1, 2), "1 Let not your heart be troubled: ye believe in God, believe also in me 2 In my Father's house are many mansions: if it were not so, I would have told you. I go to prepare a place for you."));
    }

    public Scripture GetRandomScripture()
    {
        int index = _random.Next(_scriptures.Count);
        Scripture scripture = _scriptures[index];
        return scripture;
    }


}