using SpanishApp.ModuleNamespace;

namespace SpanishApp.WordLists;
class WordLists
{
   public List<Word> moduleOneList = new List<Word>
    {
        // --- NOUNS (25) ---
        new Word("hola", "hello", "Phrase", false, 0),
        new Word("adiós", "goodbye", "Phrase", false, 0),
        new Word("por favor", "please", "Phrase", false, 0),
        new Word("gracias", "thank you", "Phrase", false, 0),
        new Word("sí", "yes", "Adverb", false, 0),
        new Word("no", "no", "Adverb", false, 0),
        new Word("el hombre", "the man", "Noun", false, 0),
        new Word("la mujer", "the woman", "Noun", false, 0),
        new Word("el niño", "the boy", "Noun", false, 0),
        new Word("la niña", "the girl", "Noun", false, 0),
        new Word("el amigo", "the friend (m)", "Noun", false, 0),
        new Word("la casa", "the house", "Noun", false, 0),
        new Word("el agua", "the water", "Noun", false, 0),
        new Word("la comida", "the food", "Noun", false, 0),
        new Word("el día", "the day", "Noun", false, 0),
        new Word("la noche", "the night", "Noun", false, 0),
        new Word("la hora", "the hour/time", "Noun", false, 0),
        new Word("el dinero", "the money", "Noun", false, 0),
        new Word("el trabajo", "the work/job", "Noun", false, 0),
        new Word("la escuela", "the school", "Noun", false, 0),
        new Word("el libro", "the book", "Noun", false, 0),
        new Word("la mesa", "the table", "Noun", false, 0),
        new Word("el coche", "the car", "Noun", false, 0),
        new Word("el perro", "the dog", "Noun", false, 0),
        new Word("el gato", "the cat", "Noun", false, 0),

        // --- ESSENTIAL VERBS (25) ---
        new Word("ser", "to be (permanent)", "Verb", true, 0), // Irregular
        new Word("estar", "to be (temporary)", "Verb", true, 0), // Irregular
        new Word("tener", "to have", "Verb", true, 0), // Irregular
        new Word("ir", "to go", "Verb", true, 0), // Irregular
        new Word("hacer", "to do/make", "Verb", true, 0), // Irregular
        new Word("poder", "to be able to/can", "Verb", true, 0), // Stem-changing
        new Word("decir", "to say/tell", "Verb", true, 0), // Irregular
        new Word("ver", "to see", "Verb", true, 0), // Irregular
        new Word("dar", "to give", "Verb", true, 0), // Irregular
        new Word("saber", "to know (facts)", "Verb", true, 0), // Irregular
        new Word("querer", "to want/love", "Verb", true, 0), // Stem-changing
        new Word("hablar", "to speak/talk", "Verb", false, 0),
        new Word("comer", "to eat", "Verb", false, 0),
        new Word("vivir", "to live", "Verb", false, 0),
        new Word("trabajar", "to work", "Verb", false, 0),
        new Word("estudiar", "to study", "Verb", false, 0),
        new Word("escuchar", "to listen", "Verb", false, 0),
        new Word("escribir", "to write", "Verb", false, 0),
        new Word("leer", "to read", "Verb", false, 0),
        new Word("comprar", "to buy", "Verb", false, 0),
        new Word("necesitar", "to need", "Verb", false, 0),
        new Word("ayudar", "to help", "Verb", false, 0),
        new Word("gustar", "to like/please", "Verb", false, 0),
        new Word("venir", "to come", "Verb", true, 0), // Irregular
        new Word("saber", "to know (information)", "Verb", true, 0), // Irregular

        // --- ADJECTIVES & ADVERBS (25) ---
        new Word("bueno", "good", "Adjective", false, 0),
        new Word("malo", "bad", "Adjective", false, 0),
        new Word("grande", "big/large", "Adjective", false, 0),
        new Word("pequeño", "small", "Adjective", false, 0),
        new Word("fácil", "easy", "Adjective", false, 0),
        new Word("difícil", "difficult", "Adjective", false, 0),
        new Word("nuevo", "new", "Adjective", false, 0),
        new Word("viejo", "old", "Adjective", false, 0),
        new Word("caliente", "hot", "Adjective", false, 0),
        new Word("frío", "cold", "Adjective", false, 0),
        new Word("feliz", "happy", "Adjective", false, 0),
        new Word("triste", "sad", "Adjective", false, 0),
        new Word("rápido", "fast/quickly", "Adverb", false, 0),
        new Word("lento", "slow/slowly", "Adverb", false, 0),
        new Word("aquí", "here", "Adverb", false, 0),
        new Word("allí", "there", "Adverb", false, 0),
        new Word("hoy", "today", "Adverb", false, 0),
        new Word("mañana", "tomorrow", "Adverb", false, 0),
        new Word("ayer", "yesterday", "Adverb", false, 0),
        new Word("mucho", "much/a lot", "Adverb", false, 0),
        new Word("poco", "little/few", "Adverb", false, 0),
        new Word("más", "more", "Adverb", false, 0),
        new Word("menos", "less", "Adverb", false, 0),
        new Word("siempre", "always", "Adverb", false, 0),
        new Word("nunca", "never", "Adverb", false, 0),

        // --- PRONOUNS, PREPOSITIONS, AND PHRASES (25) ---
        new Word("yo", "I", "Pronoun", false, 0),
        new Word("tú", "you (singular, informal)", "Pronoun", false, 0),
        new Word("él", "he", "Pronoun", false, 0),
        new Word("ella", "she", "Pronoun", false, 0),
        new Word("usted", "you (singular, formal)", "Pronoun", false, 0),
        new Word("nosotros", "we (m)", "Pronoun", false, 0),
        new Word("ellos", "they (m)", "Pronoun", false, 0),
        new Word("ustedes", "you (plural)", "Pronoun", false, 0),
        new Word("mi", "my", "Adjective", false, 0),
        new Word("tu", "your (singular, informal)", "Adjective", false, 0),
        new Word("su", "his/her/their/your (formal)", "Adjective", false, 0),
        new Word("con", "with", "Preposition", false, 0),
        new Word("sin", "without", "Preposition", false, 0),
        new Word("de", "of/from", "Preposition", false, 0),
        new Word("a", "to/at", "Preposition", false, 0),
        new Word("en", "in/on/at", "Preposition", false, 0),
        new Word("¿Cómo?", "How?", "Phrase", false, 0),
        new Word("¿Qué?", "What?", "Phrase", false, 0),
        new Word("¿Dónde?", "Where?", "Phrase", false, 0),
        new Word("¿Cuándo?", "When?", "Phrase", false, 0),
        new Word("¿Quién?", "Who?", "Phrase", false, 0),
        new Word("¿Por qué?", "Why?", "Phrase", false, 0),
        new Word("lo siento", "I'm sorry", "Phrase", true, 0), // Ser/Estar implied
        new Word("permiso", "excuse me/permission", "Phrase", false, 0),
        new Word("¿Qué tal?", "How are you?", "Phrase", false, 0)
    };
}