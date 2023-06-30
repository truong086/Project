/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.controller;

import com.btljava.Service.INhomMauService;
import com.btljava.Service.Impl.NhomMauService;
import com.btljava.daos.Inhommau;
import com.btljava.dao.impl.nhommauDao;
import com.btljava.model.nhommau;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class NhomMauController {
    private INhomMauService dao;
    
    public NhomMauController(){
        dao = new NhomMauService();
    }
    
    public boolean insert(nhommau nm) throws Exception {
        return dao.insert(nm);
    }

    
    public boolean update(nhommau nm) throws Exception {
        return dao.update(nm);
    }

    
    public boolean delete(String nm) throws Exception {
        return dao.delete(nm);
    }

    
    public List<nhommau> findAll() throws Exception {
        return dao.findAll();
    }

    
    public List<nhommau> TimKiem(String s) throws Exception {
        return dao.TimKiem(s);
    }

    
    public nhommau findAllid(int id) throws Exception {
        return dao.findAllid(id);
    }
}
