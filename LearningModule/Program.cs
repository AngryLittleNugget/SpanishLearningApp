
namespace SpanishApp.ModuleNamespace;
public class LearningModule
{
    public string name { get; }
    //public string[] nouns { get; }
    //public string[] verbs { get; }
    public Word[] words { get; }
    public Dictionary<string, string> questions{ get; }
    public LearningModule(string name,  Word[] wordList, Dictionary<string, string> questionList)
    {
        this.name = name;
        this.words = wordList;
        this.questions = questionList;
    }
}

public class Word
{
    public string spanishWord { get; }
    public string englishTranslation { get; }
    public string wordType { get; }
    public bool isIrregular { get; }
    public int masteryLevel { get; }
    public Word (string spanishWord, string englishTranslation, string wordType, bool isIrregular, int masteryLevel)
    {
        this.wordType = wordType;
        this.isIrregular = isIrregular;
        this.spanishWord = spanishWord;
        this.englishTranslation = englishTranslation;
        this.masteryLevel = masteryLevel;
    }
}