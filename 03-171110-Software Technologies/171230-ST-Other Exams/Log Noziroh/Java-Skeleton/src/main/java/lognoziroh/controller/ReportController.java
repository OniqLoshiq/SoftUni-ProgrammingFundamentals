package lognoziroh.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import lognoziroh.bindingModel.ReportBindingModel;
import lognoziroh.repository.ReportRepository;
import lognoziroh.entity.Report;

import javax.validation.Valid;
import java.util.List;

@Controller
public class ReportController {
	@Autowired
	private ReportRepository reportRepository;

	@GetMapping("/")
	public String index(Model model) {
		List<Report> reports = this.reportRepository.findAll();
		model.addAttribute("reports", reports);
		model.addAttribute("view", "report/index");
		return "base-layout";
	}

	@GetMapping("/details/{id}")
	public String details(Model model, @PathVariable int id) {
		if(!this.reportRepository.exists(id)){
			return "redirect:/";
		}
		Report report = this.reportRepository.findOne(id);
		model.addAttribute("report", report);
		model.addAttribute("view", "report/details");
		return "base-layout";
	}

	@GetMapping("/create")
	public String create(Model model) {
		model.addAttribute("view", "report/create");
		model.addAttribute("report", new ReportBindingModel());
		return "base-layout";
	}

	@PostMapping("/create")
	public String createProcess(Model model, @Valid ReportBindingModel reportBindingModel, BindingResult bindingResult) {
		if(bindingResult.hasErrors()){
			model.addAttribute("message", "Invalid data.");
			model.addAttribute("report", reportBindingModel);
			model.addAttribute("view", "report/create");
			return "base-layout";
		}
		Report report = new Report(reportBindingModel.getStatus(), reportBindingModel.getMessage(), reportBindingModel.getOrigin());
		this.reportRepository.saveAndFlush(report);
		return "redirect:/";
	}

	@GetMapping("/delete/{id}")
	public String delete(Model model, @PathVariable int id) {
		if(!this.reportRepository.exists(id)){
			return "redirect:/";
		}
		Report report = this.reportRepository.findOne(id);
		model.addAttribute("report", report);
		model.addAttribute("view", "report/delete");
		return "base-layout";
	}

	@PostMapping("/delete/{id}")
	public String deleteProcess(@PathVariable int id, ReportBindingModel reportBindingModel) {
		if(!this.reportRepository.exists(id)){
			return "redirect:/";
		}
		Report report = this.reportRepository.findOne(id);
		this.reportRepository.delete(report);
		this.reportRepository.flush();
		return "redirect:/";

	}
}
