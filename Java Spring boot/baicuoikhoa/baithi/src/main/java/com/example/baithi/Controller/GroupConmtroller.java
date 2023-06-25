package com.example.baithi.Controller;

import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.format.annotation.DateTimeFormat;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.validation.BindingResult;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.servlet.ModelAndView;

import com.example.baithi.Service.GroupService;
import com.example.baithi.model.Access;
import com.fasterxml.jackson.annotation.JsonCreator.Mode;

import jakarta.servlet.http.HttpServletRequest;

@Controller
@RequestMapping("/")
public class GroupConmtroller {
    
    @Autowired
    private GroupService groupService;

    @GetMapping
    public String home(Model model){
        model.addAttribute("findAll", groupService.findAll());
        model.addAttribute("check", new Access());
        return "home";
    }

    @GetMapping("/detail/{id}")
    public String detail(@PathVariable("id")Integer id, Model model){
        Access check = groupService.findById(id);
        if(check != null){
            model.addAttribute("check", check);
        }else{
            model.addAttribute("findAll", groupService.findAll());
        }
        return "detail";
    }

    @PostMapping("/post")
    public String AddAndEdit(@ModelAttribute("check") Access access, HttpServletRequest request ,BindingResult result, Model model){
        
        if(!result.hasErrors()){
            if(access.getId() != null){
                String id = request.getParameter("id");
        

                // Đây là chuyển đổi từ kiểu dữ liệu "String" sang kiểu dữ liệu "DateTime"
                // DateTimeFormatter fomatDate = DateTimeFormatter.ofPattern("yyyy-MM-dd HH:mm:ss"); 
                // LocalDateTime dateTime = LocalDateTime.parse(createDate, fomatDate);
                
                Integer ids = Integer.parseInt(id);
                groupService.update(ids, access);
            }else{
                String groupName = request.getParameter("groupName");
                String member = request.getParameter("member");
                String creator = request.getParameter("creator");
                String createDate = request.getParameter("createDate");
                if(member == "" || creator == null){
                    String messageMember = "Không được để trống";
                    model.addAttribute("message", messageMember);
                    model.addAttribute("findAll", groupService.findAll());
                    return "home";
                }
                Access check = groupService.checkGroup(groupName);
                if(check == null){
                    Access accesss = new Access();
                    accesss.setGroupName(groupName);
                    accesss.setMember(member);
                    accesss.setCreator(creator);
                    accesss.setCreateDate(createDate);
                    groupService.insert(accesss);
                }else{
                    String message = "Group đã bị trùng";
                    model.addAttribute("message", message);
                    model.addAttribute("findAll", groupService.findAll());
                    return "home";
                }
                
                
                
            }
        }
        model.addAttribute("findAll", groupService.findAll());
        return "redirect:/";
    }

    @GetMapping("/delete/{id}")
    public String deleteData(@PathVariable Integer id, Model model){
        groupService.delete(id);
        model.addAttribute("findAll", groupService.findAll());
        return "home";
    }

    @PostMapping("/search")
    public String timkiem(Model model, HttpServletRequest request){
        String search = request.getParameter("search");
        List<Access> list = groupService.findCheck(search);
        if(list != null){
            model.addAttribute("findAll", list);
            model.addAttribute("search", search);
        }
        return "home";
    }

}
