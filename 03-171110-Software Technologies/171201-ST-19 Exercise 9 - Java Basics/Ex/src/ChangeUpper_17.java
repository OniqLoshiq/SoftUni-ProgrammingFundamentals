import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ChangeUpper_17 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine();
        List<String> allMatches = new ArrayList<String>();
        Matcher m = Pattern.compile("(?<=<upcase>)(.*?)(?=<\\/upcase>)").matcher(text);
        while (m.find()) {
            allMatches.add(m.group(1).toUpperCase());
        }

        for (int i = 0; i < allMatches.size(); i++) {

            text = text.replaceFirst("(<upcase>)(.*?)(<\\/upcase>)", allMatches.get(i));
        }

        System.out.println(text);

    }
}
