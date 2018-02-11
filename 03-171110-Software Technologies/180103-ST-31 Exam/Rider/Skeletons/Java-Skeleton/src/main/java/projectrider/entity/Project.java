package projectrider.entity;

import javax.persistence.*;

@Entity
@Table(name = "projets")
public class Project {
    private Integer id;
    private String title;
    private String description;
    private Long budget;

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    @Column(nullable = false)
    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    @Column(nullable = false)
    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    @Column(nullable = false)
    public Long getBudget() {
        return budget;
    }

    public void setBudget(Long budget) {
        this.budget = budget;
    }

    public Project(String title, String description, Long budget) {
        this.title = title;
        this.description = description;
        this.budget = budget;
    }

    public Project() {}
}
