import java.lang.reflect.Array;
import java.util.*;

class Book{
    private String author;
    private double price;

    public Book(String author, double price) {
        this.author = author;
        this.price = price;
    }

    public String getAuthor() {

        return author;
    }

    public double getPrice() {
        return price;
    }
}
public class BookLibr_24 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());
        Map<String, Double> allBooks = new HashMap<>();

        for (int i = 0; i < n; i++) {
            List<String> input = Arrays.asList(scanner.nextLine().split("\\s+"));
            String author = input.get(1);
            double price = Double.parseDouble(input.get(5));
            Book book = new Book (author, price);

            if(!allBooks.containsKey(author)){
                allBooks.put(author, 0.0);
            }
            allBooks.put(author, allBooks.get(author) + price);
        }

        allBooks.entrySet().stream().sorted((a,b) ->
            a.getValue().equals(b.getValue()) ? a.getKey().compareTo(b.getKey()) :
                   Double.compare(b.getValue(), a.getValue()))
        .map(e -> e.getKey() + " -> " + String.format("%.2f", e.getValue()))
        .forEach(System.out::println);
    }
}
