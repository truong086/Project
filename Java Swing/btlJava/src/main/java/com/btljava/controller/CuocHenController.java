/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.controller;

import com.btljava.Service.ICuocHenService;
import com.btljava.Service.Impl.CuocHenService;
import com.btljava.daos.ICuocHen;
import com.btljava.dao.impl.cuochenDao;
import com.btljava.model.cuochen;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class CuocHenController {
    private ICuocHenService dao;
    
    public CuocHenController(){
        dao = new CuocHenService();
    }
    
    public boolean insert(cuochen ch) throws Exception {
        return dao.insert(ch);
    }

    
    public boolean update(cuochen ch) throws Exception {
        return dao.update(ch);
    }

    
    public boolean delete(String ch) throws Exception {
        return dao.delete(ch);
    }

    
    public List<cuochen> findAll() throws Exception {
        return dao.findAll();
    }

    
    public List<cuochen> timkiem(String s) throws Exception {
        return dao.timkiem(s);
    }

    
    public cuochen findbyid(int s) throws Exception {
        return dao.findbyid(s);
    }
}
