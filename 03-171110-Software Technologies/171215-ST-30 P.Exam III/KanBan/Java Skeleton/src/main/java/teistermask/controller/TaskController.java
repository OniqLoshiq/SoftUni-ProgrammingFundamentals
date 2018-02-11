package teistermask.controller;

import org.omg.PortableServer.LIFESPAN_POLICY_ID;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import teistermask.bindingModel.TaskBindingModel;
import teistermask.entity.Task;
import teistermask.repository.TaskRepository;

import javax.validation.Valid;
import java.util.List;

@Controller
public class TaskController {
	@Autowired
	private TaskRepository taskRepository;

	@GetMapping("/")
	public String index(Model model) {
		List<Task> openTasks = this.taskRepository.findAllByStatus("Open");
		List<Task> intProgressTasks = this.taskRepository.findAllByStatus("In progress");
		List<Task> finishedTasks = this.taskRepository.findAllByStatus("Finished");

		model.addAttribute("openTasks", openTasks);
		model.addAttribute("inProgressTasks", intProgressTasks);
		model.addAttribute("finishedTasks", finishedTasks);
		model.addAttribute("view", "task/index");

		return "base-layout";
	}

	@GetMapping("/create")
	public String create(Model model) {
		model.addAttribute("view", "task/create");
		model.addAttribute("task", new TaskBindingModel());
		return "base-layout";
	}

	@PostMapping("/create")
	public String createProcess(Model model, @Valid TaskBindingModel taskBindingModel, BindingResult bindingResult) {
		if(bindingResult.hasErrors()){
			model.addAttribute("message", "Invalid data.");
			model.addAttribute("task", taskBindingModel);
			model.addAttribute("view", "task/create");
			return "base-layout";
		}

		Task task = new Task(taskBindingModel.getTitle(), taskBindingModel.getStatus());
		this.taskRepository.saveAndFlush(task);
		return "redirect:/";
	}

	@GetMapping("/edit/{id}")
	public String edit(Model model, @PathVariable int id) {
		Task task = this.taskRepository.findOne(id);
		if (task == null)
			return "redirect:/";

		model.addAttribute("task", task);
		model.addAttribute("view", "task/edit");
		return "base-layout";

	}

	@PostMapping("/edit/{id}")
	public String editProcess(Model model, @PathVariable int id, @Valid TaskBindingModel taskBindingModel, BindingResult bindingResult) {

		Task task = this.taskRepository.findOne(id);
		if (task == null){
			return "redirect:/";
		}

		if(bindingResult.hasErrors()){
			model.addAttribute("message", "Invalid data.");
			model.addAttribute("task", taskBindingModel);
			model.addAttribute("view", "task/edit");
			return "base-layout";
		}

		task.setTitle(taskBindingModel.getTitle());
		task.setStatus(taskBindingModel.getStatus());
		taskRepository.saveAndFlush(task);
		return "redirect:/";
	}
}
