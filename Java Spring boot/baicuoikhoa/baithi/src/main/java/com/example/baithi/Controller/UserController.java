package com.example.baithi.Controller;

import java.util.List;

import javax.swing.text.html.parser.Entity;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.example.baithi.Service.UserService;
import com.example.baithi.model.User;

import jakarta.servlet.http.HttpServletRequest;


@Controller
@RequestMapping("/user")
public class UserController {
    @Autowired
    private UserService repo;

    @GetMapping
    public String findAll(Model model){
        model.addAttribute("findAll", repo.findAll());
        return "Users";
    }

    @PostMapping("/post")
    public String Add(@ModelAttribute("user") User user, BindingResult result, Model model, HttpServletRequest requet){
        repo.insert(user);
        
        return "redirect:/user";
    }

    @PutMapping("/edit/{id}")
    public ResponseEntity<?> edit(@RequestBody User user, Long id){
        repo.edit(id, user);
        return ResponseEntity.ok(user);
    }

    @DeleteMapping("/delete/{id}")
    public ResponseEntity<?> delete(@RequestBody Long id){
        repo.delete(id);
        return ResponseEntity.ok("Xóa thành công");
    }

    @GetMapping("/timkiem/{name}")
    public ResponseEntity<?> timkiem(@RequestBody String name){
        List<User> list = repo.findName(name);
        return ResponseEntity.ok(list);
    }
}
