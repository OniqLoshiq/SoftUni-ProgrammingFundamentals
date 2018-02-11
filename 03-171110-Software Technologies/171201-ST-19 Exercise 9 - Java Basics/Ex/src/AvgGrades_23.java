
import java.util.*;
import java.util.stream.Collectors;

class Student {
    private String name;
    private List<Double> grades;
    private double avgGrade;

    public Student(String name, List<Double> grades) {
        this.name = name;
        this.grades = grades;
    }

    public String getName() {
        return name;
    }

    public List<Double> getGrades() {
        return grades;
    }

    public double getAvgGrade() {
        return avgGrade = getGrades().stream().mapToDouble(x -> x).average().getAsDouble();
    }
}

public class AvgGrades_23 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());
        List<Student> allStudents = new ArrayList<>();


        for (int i = 0; i < n; i++) {
            List<String> input = Arrays.asList(scanner.nextLine().split("\\s+"));
            String name = input.get(0);
            List<Double> grades = input.stream().skip(1).map(Double::parseDouble).collect(Collectors.toList());

            Student student = new Student(name, grades);
            student.getAvgGrade();
            allStudents.add(student);
        }
        allStudents = allStudents.stream().filter(x -> x.getAvgGrade() >= 5.0).collect(Collectors.toCollection(ArrayList::new));
        allStudents.sort(Comparator.comparing(Student::getName).thenComparing(Comparator.comparingDouble(Student::getAvgGrade).reversed()));

        for (Student student : allStudents) {
            System.out.printf("%s -> %.2f%n", student.getName(), student.getAvgGrade());
        }
    }
}
