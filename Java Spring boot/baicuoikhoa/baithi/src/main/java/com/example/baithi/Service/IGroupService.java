package com.example.baithi.Service;

import java.util.List;

import com.example.baithi.model.Access;

public interface IGroupService {
    public List<Access> findAll();
    public boolean insert(Access gr);
    public boolean update(Integer id, Access gr);
    public void delete(Integer id);
    public Access findById(Integer id);
    public List<Access> findCheck(String groupName);
    public Access checkGroup(String name);
}
