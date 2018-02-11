import java.util.Random;
import java.util.Scanner;

public class AdvMsg_21 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] phrases = {"Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can't live without this product."};
        Random phraseIndex = new Random();

        String[] events = {"Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"};
        Random eventsIndex = new Random();

        String[] author = {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
        Random authorIndex = new Random();

        String[] cities = {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};
        Random citiesIndex = new Random();

        int n = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i < n; i++) {
            System.out.printf("%s %s %s - %s%n", phrases[phraseIndex.nextInt(phrases.length)],
                    events[eventsIndex.nextInt(events.length)],
                    author[eventsIndex.nextInt(author.length)],
                    cities[citiesIndex.nextInt(cities.length)]);
        }
    }
}
