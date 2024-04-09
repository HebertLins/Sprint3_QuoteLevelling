package br.com.fiap.quotelevelling.endereco;


import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.MessageSource;
import org.springframework.context.i18n.LocaleContextHolder;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;

import jakarta.validation.Valid;

@Controller
@RequestMapping("enderecos")
public class EnderecoController {
    
    @Autowired
    EnderecoRepository repository;

    @Autowired
    MessageSource messageSource;

    @GetMapping
    public String index(Model model){
        model.addAttribute("enderecos", repository.findAll());
        return "endereco/index";
    }

    @GetMapping("new")
    public String form(Endereco endereco){
        return "endereco/form";
    }

    @PostMapping
    public String insert(@Valid Endereco endereco, BindingResult result, RedirectAttributes redirect){
        if (result.hasErrors())return "endereco/form";
        repository.save(endereco);
        redirect.addFlashAttribute("message", messageSource.getMessage("endereco.create", null , LocaleContextHolder.getLocale()));
        return "redirect:/enderecos";
    }

    @DeleteMapping("{id}")
    public String delete(@PathVariable Long id, RedirectAttributes redirect){
        var endereco = repository.findById(id);

        if (endereco.isEmpty()){
            redirect.addFlashAttribute("message", "Erro ao apagar. Endereco não encontrado");
            return "redirect:/enderecos";
        }
        
        repository.deleteById(id);
        redirect.addFlashAttribute("message", messageSource.getMessage("endereco.delete", null, LocaleContextHolder.getLocale()));
        return "redirect:/enderecos";
    }
}
