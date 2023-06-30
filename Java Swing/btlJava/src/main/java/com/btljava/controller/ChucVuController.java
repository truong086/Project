/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.controller;

import com.btljava.Service.IChucVuService;
import com.btljava.Service.Impl.ChucVuService;
import com.btljava.daos.Ichucvu;
import com.btljava.dao.impl.chucvuDao;
import com.btljava.model.chucvu;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class ChucVuController {
    private IChucVuService dao;
    
    public ChucVuController(){
        dao = new ChucVuService();
    }
    
    
    public boolean insert(chucvu cv) throws Exception {
        return dao.insert(cv);
    }

    
    public boolean update(chucvu cv) throws Exception {
        return dao.update(cv);
    }

    
    public boolean delete(String id) throws Exception {
        return dao.delete(id);
    }

    
    public List<chucvu> findAll() throws Exception {
        return dao.findAll();
    }

    
    public List<chucvu> timkiem(String s) throws Exception {
        return dao.timkiem(s);
    }

    
    public chucvu findAllid(int n) throws Exception {
        return dao.findAllid(n);
    }

    
    public chucvu findAllids(int n) throws Exception {
        return dao.findAllids(n);
    }
}
