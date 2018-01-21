package lab2;

import lab2.Window;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.Arrays;
import java.util.regex.Pattern;

public class Nerc {

    /** Labels that we will attach to the words*/
    public enum Class {
        ARTIFACT, EVENT, GEO, NATURAL, ORGANIZATION, PERSON, TIME, OTHER
    }

    /** Determines the class for the word at position 0 in the window*/
    public static Class findClass(Window window) {
        String[] stopwords = {"a", "as", "able", "about", "above", "according", "accordingly", "across", "actually", "after", "afterwards", "again", "against", "aint", "all", "allow", "allows", "almost", "alone", "along", "already", "also", "although", "always", "am", "among", "amongst", "an", "and", "another", "any", "anybody", "anyhow", "anyone", "anything", "anyway", "anyways", "anywhere", "apart", "appear", "appreciate", "appropriate", "are", "arent", "around", "as", "aside", "ask", "asking", "associated", "at", "available", "away", "awfully", "be", "became", "because", "become", "becomes", "becoming", "been", "before", "beforehand", "behind", "being", "believe", "below", "beside", "besides", "best", "better", "between", "beyond", "both", "brief", "but", "by", "cmon", "cs", "came", "can", "cant", "cannot", "cant", "cause", "causes", "certain", "certainly", "changes", "clearly", "co", "com", "come", "comes", "concerning", "consequently", "consider", "considering", "contain", "containing", "contains", "corresponding", "could", "couldnt", "course", "currently", "definitely", "described", "despite", "did", "didnt", "different", "do", "does", "doesnt", "doing", "dont", "done", "down", "downwards", "during", "each", "edu", "eg", "eight", "either", "else", "elsewhere", "enough", "entirely", "especially", "et", "etc", "even", "ever", "every", "everybody", "everyone", "everything", "everywhere", "ex", "exactly", "example", "except", "far", "few", "ff", "fifth", "first", "five", "followed", "following", "follows", "for", "former", "formerly", "forth", "four", "from", "further", "furthermore", "get", "gets", "getting", "given", "gives", "go", "goes", "going", "gone", "got", "gotten", "greetings", "had", "hadnt", "happens", "hardly", "has", "hasnt", "have", "havent", "having", "he", "hes", "hello", "help", "hence", "her", "here", "heres", "hereafter", "hereby", "herein", "hereupon", "hers", "herself", "hi", "him", "himself", "his", "hither", "hopefully", "how", "howbeit", "however", "i", "id", "ill", "im", "ive", "ie", "if", "ignored", "immediate", "in", "inasmuch", "inc", "indeed", "indicate", "indicated", "indicates", "inner", "insofar", "instead", "into", "inward", "is", "isnt", "it", "itd", "itll", "its", "its", "itself", "just", "keep", "keeps", "kept", "know", "knows", "known", "last", "lately", "later", "latter", "latterly", "least", "less", "lest", "let", "lets", "like", "liked", "likely", "little", "look", "looking", "looks", "ltd", "mainly", "many", "may", "maybe", "me", "mean", "meanwhile", "merely", "might", "more", "moreover", "most", "mostly", "much", "must", "my", "myself", "name", "namely", "nd", "near", "nearly", "necessary", "need", "needs", "neither", "never", "nevertheless", "new", "next", "nine", "no", "nobody", "non", "none", "noone", "nor", "normally", "not", "nothing", "novel", "now", "nowhere", "obviously", "of", "off", "often", "oh", "ok", "okay", "old", "on", "once", "one", "ones", "only", "onto", "or", "other", "others", "otherwise", "ought", "our", "ours", "ourselves", "out", "outside", "over", "overall", "own", "particular", "particularly", "per", "perhaps", "placed", "please", "plus", "possible", "presumably", "probably", "provides", "que", "quite", "qv", "rather", "rd", "re", "really", "reasonably", "regarding", "regardless", "regards", "relatively", "respectively", "right", "said", "same", "saw", "say", "saying", "says", "second", "secondly", "see", "seeing", "seem", "seemed", "seeming", "seems", "seen", "self", "selves", "sensible", "sent", "serious", "seriously", "seven", "several", "shall", "she", "should", "shouldnt", "since", "six", "so", "some", "somebody", "somehow", "someone", "something", "sometime", "sometimes", "somewhat", "somewhere", "soon", "sorry", "specified", "specify", "specifying", "still", "sub", "such", "sup", "sure", "ts", "take", "taken", "tell", "tends", "th", "than", "thank", "thanks", "thanx", "that", "thats", "thats", "the", "their", "theirs", "them", "themselves", "then", "thence", "there", "theres", "thereafter", "thereby", "therefore", "therein", "theres", "thereupon", "these", "they", "theyd", "theyll", "theyre", "theyve", "think", "third", "this", "thorough", "thoroughly", "those", "though", "three", "through", "throughout", "thru", "thus", "to", "together", "too", "took", "toward", "towards", "tried", "tries", "truly", "try", "trying", "twice", "two", "un", "under", "unfortunately", "unless", "unlikely", "until", "unto", "up", "upon", "us", "use", "used", "useful", "uses", "using", "usually", "value", "various", "very", "via", "viz", "vs", "want", "wants", "was", "wasnt", "way", "we", "wed", "well", "were", "weve", "welcome", "well", "went", "were", "werent", "what", "whats", "whatever", "when", "whence", "whenever", "where", "wheres", "whereafter", "whereas", "whereby", "wherein", "whereupon", "wherever", "whether", "which", "while", "whither", "who", "whos", "whoever", "whole", "whom", "whose", "why", "will", "willing", "wish", "with", "within", "without", "wont", "wonder", "would", "would", "wouldnt", "yes", "yet", "you", "youd", "youll", "youre", "youve", "your", "yours", "yourself", "yourselves", "zero"};        // if sentence number is the same with the first element
        String[] punc = {";",":",",",".","!","?"};
        String[] monthAbb = {"Jan.", "Feb.", "Mar.", "Apr.", "Jun.", "Jul.", "Aug.", "Sept.", "Oct.", "Nov.", "Dec."};
        String[] monthNames = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
        String[] dayNames = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
        String[] seasons = {"Winter","Summer","Spring","Autumn"};
        String[] timeInDay = {"Afternoon","Noon","Morning","afternoon","noon","morning","p.m","a.m","P.M","A.M"};
        String[] century = {"Eve", "eve", "century","centuries"};
        String fourDigits = "(\\d{4})";
        String twoDigits = "(\\d{2})";
        String[] since = {"Since","since"};

        String[] natural = {"Hurricane","Hurricanes","H5N1","Katrina", "AIDS", "HIV"};

        String[] event = {"I","II", "World", "War", "Cup"};

        String[] artifact = {"Nobel","nobel"};

        String[] person = {"Mustafa","Kemal", "Ataturk", "ATATURK"};
        String title = "(Dr.|Prof.|Mr.|Ms.|PhD)";
        String space = " ";
        String name = "[A-Z][a-z]+";
        String optinalName = "( [A-Z][a-z]+)*";
        String names = name + optinalName;
        String president = "(President|president)";

        String uppercase = "[A-Z][A-Z0-9]+";

        String bigCompanies = "Microsoft Google google microsoft";
        String identifyCompany = ".*(Inc.|Corp.|Ltd.)";// not working

        //String[] country = {"Andorra", "United Arab Emirates", "Afghanistan", "Antigua and Barbuda", "Anguilla", "Albania", "Armenia", "Netherlands Antilles", "Angola", "Antarctica", "Argentina", "American Samoa", "Austria", "Australia", "Aruba", "Åland Islands", "Azerbaijan", "Bosnia and Herzegovina", "Barbados", "Bangladesh", "Belgium", "Burkina Faso", "Bulgaria", "Bahrain", "Burundi", "Benin", "Saint Barthélemy", "Bermuda", "Brunei", "Bolivia", "Bonaire, Sint Eustatius and Saba", "Brazil", "Bahamas", "Bhutan", "Bouvet Island", "Botswana", "Belarus", "Belize", "Canada", "Cocos Islands", "The Democratic Republic Of Congo", "Central African Republic", "Congo", "Switzerland", "Côte d'Ivoire", "Cook Islands", "Chile", "Cameroon", "China", "Colombia", "Costa Rica", "Cuba", "Cape Verde", "Curaçao", "Christmas Island", "Cyprus", "Czech Republic", "Germany", "Djibouti", "Denmark", "Dominica", "Dominican Republic", "Algeria", "Ecuador", "Estonia", "Egypt", "Western Sahara", "Eritrea", "Spain", "Ethiopia", "Finland", "Fiji", "Falkland Islands", "Micronesia", "Faroe Islands", "France", "Gabon", "United Kingdom", "Grenada", "Georgia", "French Guiana", "Guernsey", "Ghana", "Gibraltar", "Greenland", "Gambia", "Guinea", "Guadeloupe", "Equatorial Guinea", "Greece", "South Georgia And The South Sandwich Islands", "Guatemala", "Guam", "Guinea-Bissau", "Guyana", "Hong Kong", "Heard Island And McDonald Islands", "Honduras", "Croatia", "Haiti", "Hungary", "Indonesia", "Ireland", "Israel", "Isle Of Man", "India", "British Indian Ocean Territory", "Iraq", "Iran", "Iceland", "Italy", "Jersey", "Jamaica", "Jordan", "Japan", "Kenya", "Kyrgyzstan", "Cambodia", "Kiribati", "Comoros", "Saint Kitts And Nevis", "North Korea", "South Korea", "Kuwait", "Cayman Islands", "Kazakhstan", "Laos", "Lebanon", "Saint Lucia", "Liechtenstein", "Sri Lanka", "Liberia", "Lesotho", "Lithuania", "Luxembourg", "Latvia", "Libya", "Morocco", "Monaco", "Moldova", "Montenegro", "Saint Martin", "Madagascar", "Marshall Islands", "Macedonia", "Mali", "Myanmar", "Mongolia", "Macao", "Northern Mariana Islands", "Martinique", "Mauritania", "Montserrat", "Malta", "Mauritius", "Maldives", "Malawi", "Mexico", "Malaysia", "Mozambique", "Namibia", "New Caledonia", "Niger", "Norfolk Island", "Nigeria", "Nicaragua", "Netherlands", "Norway", "Nepal", "Nauru", "Niue", "New Zealand", "Oman", "Panama", "Peru", "French Polynesia", "Papua New Guinea", "Philippines", "Pakistan", "Poland", "Saint Pierre And Miquelon", "Pitcairn", "Puerto Rico", "Palestine", "Portugal", "Palau", "Paraguay", "Qatar", "Reunion", "Romania", "Serbia", "Russia", "Rwanda", "Saudi Arabia", "Solomon Islands", "Seychelles", "Sudan", "Sweden", "Singapore", "Saint Helena", "Slovenia", "Svalbard And Jan Mayen", "Slovakia", "Sierra Leone", "San Marino", "Senegal", "Somalia", "Suriname", "South Sudan", "Sao Tome And Principe", "El Salvador", "Sint Maarten (Dutch part)", "Syria", "Swaziland", "Turks And Caicos Islands", "Chad", "French Southern Territories", "Togo", "Thailand", "Tajikistan", "Tokelau", "Timor-Leste", "Turkmenistan", "Tunisia", "Tonga", "Turkey", "Trinidad and Tobago", "Tuvalu", "Taiwan", "Tanzania", "Ukraine", "Uganda", "United States Minor Outlying Islands", "United States", "Uruguay", "Uzbekistan", "Vatican", "Saint Vincent And The Grenadines", "Venezuela", "British Virgin Islands", "U.S. Virgin Islands", "Vietnam", "Vanuatu", "Wallis And Futuna", "Samoa", "Yemen", "Mayotte", "South Africa", "Zambia", "Zimbabwe"};
        String country = "(Andorra|United Arab Emirates|Afghanistan|Antigua and Barbuda|Anguilla|Albania|Armenia|Netherlands Antilles|Angola|Antarctica|Argentina|American Samoa|Austria|Australia|Aruba|Åland Islands|Azerbaijan|Bosnia and Herzegovina|Barbados|Bangladesh|Belgium|Burkina Faso|Bulgaria|Bahrain|Burundi|Benin|Saint Barthélemy|Bermuda|Brunei|Bolivia|Bonaire, Sint Eustatius and Saba|Brazil|Bahamas|Bhutan|Bouvet Island|Botswana|Belarus|Belize|Canada|Cocos Islands|The Democratic Republic Of Congo|Central African Republic|Congo|Switzerland|Côte d'Ivoire|Cook Islands|Chile|Cameroon|China|Colombia|Costa Rica|Cuba|Cape Verde|Curaçao|Christmas Island|Cyprus|Czech Republic|Germany|Djibouti|Denmark|Dominica|Dominican Republic|Algeria|Ecuador|Estonia|Egypt|Western Sahara|Eritrea|Spain|Ethiopia|Finland|Fiji|Falkland Islands|Micronesia|Faroe Islands|France|Gabon|United Kingdom|Grenada|Georgia|French Guiana|Guernsey|Ghana|Gibraltar|Greenland|Gambia|Guinea|Guadeloupe|Equatorial Guinea|Greece|South Georgia And The South Sandwich Islands|Guatemala|Guam|Guinea-Bissau|Guyana|Hong Kong|Heard Island And McDonald Islands|Honduras|Croatia|Haiti|Hungary|Indonesia|Ireland|Israel|Isle Of Man|India|British Indian Ocean Territory|Iraq|Iran|Iceland|Italy|Jersey|Jamaica|Jordan|Japan|Kenya|Kyrgyzstan|Cambodia|Kiribati|Comoros|Saint Kitts And Nevis|North Korea|South Korea|Kuwait|Cayman Islands|Kazakhstan|Laos|Lebanon|Saint Lucia|Liechtenstein|Sri Lanka|Liberia|Lesotho|Lithuania|Luxembourg|Latvia|Libya|Morocco|Monaco|Moldova|Montenegro|Saint Martin|Madagascar|Marshall Islands|Macedonia|Mali|Myanmar|Mongolia|Macao|Northern Mariana Islands|Martinique|Mauritania|Montserrat|Malta|Mauritius|Maldives|Malawi|Mexico|Malaysia|Mozambique|Namibia|New Caledonia|Niger|Norfolk Island|Nigeria|Nicaragua|Netherlands|Norway|Nepal|Nauru|Niue|New Zealand|Oman|Panama|Peru|French Polynesia|Papua New Guinea|Philippines|Pakistan|Poland|Saint Pierre And Miquelon|Pitcairn|Puerto Rico|Palestine|Portugal|Palau|Paraguay|Qatar|Reunion|Romania|Serbia|Russia|Rwanda|Saudi Arabia|Solomon Islands|Seychelles|Sudan|Sweden|Singapore|Saint Helena|Slovenia|Svalbard And Jan Mayen|Slovakia|Sierra Leone|San Marino|Senegal|Somalia|Suriname|South Sudan|Sao Tome And Principe|El Salvador|Sint Maarten (Dutch part)|Syria|Swaziland|Turks And Caicos Islands|Chad|French Southern Territories|Togo|Thailand|Tajikistan|Tokelau|Timor-Leste|Turkmenistan|Tunisia|Tonga|Turkey|Trinidad and Tobago|Tuvalu|Taiwan|Tanzania|Ukraine|Uganda|United States Minor Outlying Islands|United States|Uruguay|Uzbekistan|Vatican|Saint Vincent And The Grenadines|Venezuela|British Virgin Islands|U.S. Virgin Islands|Vietnam|Vanuatu|Wallis And Futuna|Samoa|Yemen|Mayotte|South Africa|Zambia|Zimbabwe)";
        String[] cityIndicators = {"of","near","to","from"};
        String endingWish = ".*ish$";

        String word = window.getWordAt(0);
        String nWords = "";

        for (int i = 1; i < window.width + 1; i++) {
            if (window.getSentenceNumberAt(0).equals(window.getSentenceNumberAt(i)))
                nWords += window.getWordAt(i) + space;
            else break;
        }

        if(window.getClassAt(0) == null) {

            if (!Arrays.asList(stopwords).contains(word)) {
                if (word.matches(fourDigits)){
                    return (Class.TIME);
                }
                else if (Arrays.asList(monthAbb).contains(word)){
                    return (Class.TIME);
                }
                else if (Arrays.asList(since).contains(word)){
                    if (window.getWordAt(1).matches(fourDigits) || Arrays.asList(monthNames).contains(window.getWordAt(1)) || Arrays.asList(dayNames).contains(window.getWordAt(1)))
                        return (Class.TIME);
                }
                else if (word.matches(twoDigits)) {
                    if ((Arrays.asList(monthNames).contains(window.getWordAt(-1))) || (Arrays.asList(monthNames).contains(window.getWordAt(1))) || (Arrays.asList(dayNames).contains(window.getWordAt(-1))) || (Arrays.asList(dayNames).contains(window.getWordAt(1))))
                        return (Class.TIME);
                }
                else if(Arrays.asList(monthNames).contains(word) || Arrays.asList(dayNames).contains(word) ||Arrays.asList(seasons).contains(word) ||Arrays.asList(timeInDay).contains(word) ||Arrays.asList(century).contains(word))
                    return (Class.TIME);

                else if (Pattern.compile(endingWish).matcher(word).find()){
                    return (Class.GEO);
                }
                else if (Pattern.compile(country).matcher(word).find()){
                    return (Class.GEO);
                }
                else if (Pattern.compile(country).matcher(window.getWordAt(-1)).find()){
                    if(window.getTagAt(0).equals("NNP"))
                        return (Class.GEO);
                }
                else if (Arrays.asList(cityIndicators).contains(window.getWordAt(-1))){
                    if(window.getTagAt(0).equals("NNP"))
                        return (Class.GEO);
                }

                else if(Pattern.compile(title + space + names).matcher(nWords).find()) {
                    for (int i = 1; i < window.width + 1; i++) {
                            if(window.getTagAt(i).equals("NNP"))
                                window.setClassAt(i,Class.PERSON);
                    }
                }
                else if (Pattern.compile(president + space + names).matcher(nWords).find()){
                    for (int i = 1; i < window.width + 1; i++) {
                        if(window.getTagAt(i).equals("NNP"))
                            window.setClassAt(i,Class.PERSON);
                    }
                }
                else if(Arrays.asList(person).contains(word))
                    return (Class.PERSON);

                else if(Arrays.asList(natural).contains(word))
                    return (Class.NATURAL);

                else if(Arrays.asList(event).contains(word))
                    return (Class.EVENT);

                else if(Arrays.asList(artifact).contains(word))
                    return (Class.ARTIFACT);

                else if(Pattern.compile(identifyCompany).matcher(nWords).find()) {
                    for (int i = 1; i < window.width + 1; i++) {
                        if(window.getTagAt(i).equals("NNP"))
                            window.setClassAt(i,Class.ORGANIZATION);
                    }
                }

                else if (word.matches(uppercase))
                    return (Class.ORGANIZATION);

                else if (bigCompanies.contains(word))
                    return (Class.ORGANIZATION);

                else if(Pattern.compile("The"+ space + names).matcher(nWords).find()) {
                    for (int i = 1; i < window.width + 1; i++) {
                        if(window.getTagAt(i).equals("NNP"))
                            window.setClassAt(i,Class.ORGANIZATION);
                    }
                }

                else if(Pattern.compile(name).matcher(word).find()) {
                    if(window.getTagAt(0).equals("NNP") && window.getTagAt(1).startsWith("V"))
                        return (Class.PERSON);
                }

            }
            return (Class.OTHER);
        }
        return window.getClassAt(0);
    }

    /** Takes as arguments:
     * (1) a testing file with sentences
     * (2) optionally: a training file with labeled sentences
     * 
     *  Writes to the file result.tsv lines of the form
     *     X-WORD \t CLASS
     *  where X is a sentence number, WORD is a word, and CLASS is a class.
     */

    public static void main(String[] args) throws IOException {
        //args = new String[] { "/home/mert/IdeaProjects/Knowledge_Base_Construction_Lab2/ner-test.tsv"};

        // EXPERIMENTAL: If you wish, you can train a KNN classifier here
        // on the file args[1].
        // KNN<lab2.Nerc.Class> knn = new KNN<>(5);
        // knn.addTrainingExample(lab2.Nerc.Class.ARTIFACT, 1, 2, 3);

        try (BufferedWriter out = Files.newBufferedWriter(Paths.get("result.tsv"))) {
            try (BufferedReader in = Files.newBufferedReader(Paths.get(args[0]))) {
                String line;
                Window window = new Window(5);
                while (null != (line = in.readLine())) {
                    window.add(line);
                    if (window.getWordAt(-window.width) == null) continue;
                    Class c = findClass(window);
                    if (c != null && c != Class.OTHER)
                        out.write(window.getSentenceNumberAt(0) + "-" + window.getWordAt(0) + "\t" + c + "\n");
                }
            }
        }
    }
}
