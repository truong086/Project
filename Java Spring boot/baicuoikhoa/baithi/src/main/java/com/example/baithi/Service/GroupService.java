package com.example.baithi.Service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.baithi.Reponsition.GroupReponsition;
import com.example.baithi.model.Access;

@Service
public class GroupService implements IGroupService{

    @Autowired
    private GroupReponsition repo;

    @Override
    public List<Access> findAll() {
        // TODO Auto-generated method stub
        return repo.findAll();
    }

    @Override
    public boolean insert(Access gr) {
        // TODO Auto-generated method stub
        return repo.save(gr) != null;
    }

    @Override
    public boolean update(Integer id, Access gr) {
        // TODO Auto-generated method stub
        Access check = repo.findById(id).get();
        if(check != null){
            return repo.save(gr) != null;
        }

        return null == null;
        
    }

    @Override
    public void delete(Integer id) {
        id = null;
        repo.deleteById(id);
    }

    @Override
    public Access findById(Integer id) {
        // TODO Auto-generated method stub
        Access check = repo.findById(id).orElse(null);
        if(check != null){
            return check;
        }

        return null;
    }

    @Override
    public List<Access> findCheck(String groupName) {
        // TODO Auto-generated method stub
        List<Access> check = repo.findCheck(groupName);
        if(check != null){
            return check;
        }
        return null;
    }

    @Override
    public Access checkGroup(String name) {
        // TODO Auto-generated method stub
        return repo.checkGroup(name);
    }
    
}
