/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service.Impl;

import com.btljava.Service.INhomMauService;
import com.btljava.daos.Inhommau;
import com.btljava.dao.impl.nhommauDao;
import com.btljava.model.nhommau;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class NhomMauService implements INhomMauService{

    private Inhommau dao;
    
    public NhomMauService(){
        dao = new nhommauDao();
    }
    @Override
    public boolean insert(nhommau nm) throws Exception {
        return dao.insert(nm);
    }

    @Override
    public boolean update(nhommau nm) throws Exception {
        return dao.update(nm);
    }

    @Override
    public boolean delete(String nm) throws Exception {
        return dao.delete(nm);
    }

    @Override
    public List<nhommau> findAll() throws Exception {
        return dao.findAll();
    }

    @Override
    public List<nhommau> TimKiem(String s) throws Exception {
        return dao.TimKiem(s);
    }

    @Override
    public nhommau findAllid(int id) throws Exception {
        return dao.findAllid(id);
    }
    
}
