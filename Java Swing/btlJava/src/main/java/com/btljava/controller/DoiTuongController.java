/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.controller;

import com.btljava.Service.IDoiTuongService;
import com.btljava.Service.Impl.DoiTuongService;
import com.btljava.daos.Idoituong;
import com.btljava.dao.impl.doituongDao;
import com.btljava.model.doituong;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class DoiTuongController {
    private IDoiTuongService dao;
    
    public DoiTuongController(){
        dao = new DoiTuongService();
    }
    
    public boolean insert(doituong dt) throws Exception {
        return dao.insert(dt);
    }

    
    public boolean update(doituong dt) throws Exception {
        return dao.update(dt);
    }

    
    public boolean delete(String id) throws Exception {
        return dao.delete(id);
    }

    
    public List<doituong> findAll() throws Exception {
        return dao.findAll();
    }

    
    public List<doituong> findBy(String id) throws Exception {
        return dao.findBy(id);
    }

    
    public doituong findBys(int madoituong) throws Exception {
        return dao.findBys(madoituong);
    }

    
    public doituong findByss(int madoituong) throws Exception {
        return dao.findByss(madoituong);
    }
}
