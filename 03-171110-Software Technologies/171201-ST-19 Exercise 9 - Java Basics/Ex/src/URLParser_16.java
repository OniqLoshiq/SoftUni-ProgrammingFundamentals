import java.util.Scanner;

public class URLParser_16 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();

        int indexProtocol = input.indexOf("://");
        String protocol = "";
        if(indexProtocol >= 0){
            protocol = input.substring(0, indexProtocol);
            input = input.substring(indexProtocol + 3);
        }

        int indexServer = input.indexOf("/");
        String server = input;
        if(indexServer >= 0){
            server = input.substring(0, indexServer);
            input = input.substring(indexServer + 1);
        }

        String resources = input;
        if (input == server)
        {
            resources = "";
        }

        System.out.printf("[protocol] = \"%s\"%n", protocol);
        System.out.printf("[server] = \"%s\"%n", server);
        System.out.printf("[resource] = \"%s\"%n", resources);
    }
}
