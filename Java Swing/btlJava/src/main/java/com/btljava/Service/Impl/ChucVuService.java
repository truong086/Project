/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service.Impl;

import com.btljava.Service.IChucVuService;
import com.btljava.daos.Ichucvu;
import com.btljava.dao.impl.chucvuDao;
import com.btljava.model.chucvu;
import java.util.List;



/**
 *
 * @author ASUS
 */
public class ChucVuService implements IChucVuService{
    
    private Ichucvu dao;
    
    public ChucVuService(){
        dao = new chucvuDao();
    }
    
    @Override
    public boolean insert(chucvu cv) throws Exception {
        return dao.insert(cv);
    }

    @Override
    public boolean update(chucvu cv) throws Exception {
        return dao.update(cv);
    }

    @Override
    public boolean delete(String id) throws Exception {
        return dao.delete(id);
    }

    @Override
    public List<chucvu> findAll() throws Exception {
        return dao.findAll();
    }

    @Override
    public List<chucvu> timkiem(String s) throws Exception {
        return dao.timkiem(s);
    }

    @Override
    public chucvu findAllid(int n) throws Exception {
        return dao.findAllid(n);
    }

    @Override
    public chucvu findAllids(int n) throws Exception {
        return dao.findAllids(n);
    }

    
    
}
