/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service.Impl;

import com.btljava.Service.IGiuongNguService;
import com.btljava.daos.IGiuongNgu;
import com.btljava.dao.impl.giuongnguDao;
import com.btljava.model.giuongngu;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class GiuongNguService implements IGiuongNguService{
    
    private IGiuongNgu dao;
    
    public GiuongNguService(){
        dao = new giuongnguDao();
    }

    @Override
    public boolean insert(giuongngu gn) throws Exception {
        return dao.insert(gn);
    }

    @Override
    public boolean update(giuongngu gn) throws Exception {
        return dao.update(gn);
    }

    @Override
    public boolean delete(String gn) throws Exception {
        return dao.delete(gn);
    }

    @Override
    public List<giuongngu> findAll() throws Exception {
        return dao.findAll();
    }

    @Override
    public List<giuongngu> timkiem(String s) throws Exception {
        return dao.timkiem(s);
    }

    @Override
    public giuongngu findbyid(int s) throws Exception {
        return dao.findbyid(s);
    }
    
}
