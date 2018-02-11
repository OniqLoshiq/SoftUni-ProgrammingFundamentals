package shoppinglist.controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import shoppinglist.bindingModel.ProductBindingModel;
import shoppinglist.entity.Product;
import shoppinglist.repository.ProductRepository;

import javax.validation.Valid;
import java.util.Collections;
import java.util.Comparator;
import java.util.List;

@Controller
public class ProductController {

	@Autowired
	private ProductRepository productRepository;

	@GetMapping("/")
	public String index(Model model) {
		List<Product> products = this.productRepository.findAll();
		Collections.sort(products, Comparator.comparingInt(Product::getPriority));

		model.addAttribute("products", products);
		model.addAttribute("view", "product/index");
		return "base-layout";
	}

	@GetMapping("/create")
	public String create(Model model) {
		model.addAttribute("product", new ProductBindingModel());
		model.addAttribute("view", "product/create");

		return "base-layout";
	}

	@PostMapping("/create")
	public String createProcess(Model model, @Valid ProductBindingModel productBindingModel, BindingResult bindingResult) {
		if(bindingResult.hasErrors()){
			model.addAttribute("message", "Cannot create product.");
			model.addAttribute("product", productBindingModel);
			model.addAttribute("view", "product/create");
			return "base-layout";
		}

		Product product = new Product(productBindingModel.getPriority(),
				productBindingModel.getName(),
				productBindingModel.getQuantity(),
				productBindingModel.getStatus());

		this.productRepository.saveAndFlush(product);
		return "redirect:/";
	}

	@GetMapping("/edit/{id}")
	public String edit(Model model, @PathVariable int id) {
		if(!this.productRepository.exists(id)){
			return "redirect:/";
		}
		Product product = this.productRepository.findOne(id);
		model.addAttribute("product", product);
		model.addAttribute("view", "product/edit");
		return "base-layout";
	}

	@PostMapping("/edit/{id}")
	public String editProcess(Model model, @PathVariable int id, @Valid ProductBindingModel productBindingModel, BindingResult bindingResult) {
		if(bindingResult.hasErrors()){
			model.addAttribute("message", "Cannot edit product.");
			model.addAttribute("product", productBindingModel);
			model.addAttribute("view", "product/edit");
			return "base-layout";
		}
		if(!this.productRepository.exists(id)){
			return "redirect:/";
		}
		Product product = this.productRepository.findOne(id);
		product.setPriority(productBindingModel.getPriority());
		product.setName(productBindingModel.getName());
		product.setQuantity(productBindingModel.getQuantity());
		product.setStatus(productBindingModel.getStatus());
		this.productRepository.saveAndFlush(product);
		return "redirect:/";
	}
}
