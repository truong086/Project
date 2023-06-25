package com.example.baithi.Service;

import java.util.List;

import com.example.baithi.model.User;


public interface IUserService {
    public List<User> findAll();
    public boolean insert(User user);
    public boolean edit(Long id, User user);
    public void delete(Long id);
    public List<User> findName(String name);
    public List<User> sapxep();
}
