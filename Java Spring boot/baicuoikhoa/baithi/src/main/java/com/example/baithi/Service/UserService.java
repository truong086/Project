package com.example.baithi.Service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.baithi.Reponsition.UserReponsition;
import com.example.baithi.model.User;



@Service
public class UserService implements IUserService{

    @Autowired
    private UserReponsition repo;
    @Override
    public List<User> findAll() {
        // TODO Auto-generated method stub
        return repo.findAll();
    }

    @Override
    public boolean insert(User user) {
        // TODO Auto-generated method stub
        return repo.save(user) != null;
    }

    @Override
    public boolean edit(Long id, User user) {
        // TODO Auto-generated method stub
        // true: ==> ? edit
        // false: ==> ? k edit
        User check = repo.findById(id).get();
        // check == null
        if(check != null){
            return repo.save(user) != null;
        }
        return false;
    }

    @Override
    public void delete(Long id) {
        // TODO Auto-generated method stub
        repo.deleteById(id);
    }

    @Override
    public List<User> findName(String name) {
        // TODO Auto-generated method stub
        return repo.findCheck(name);
    }

    @Override
    public List<User> sapxep() {
        // TODO Auto-generated method stub
        return repo.sapxep();
    }
    
}
