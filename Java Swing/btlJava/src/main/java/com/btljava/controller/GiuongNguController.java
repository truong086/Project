/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.controller;

import com.btljava.Service.IGiuongNguService;
import com.btljava.Service.Impl.GiuongNguService;
import com.btljava.daos.IGiuongNgu;
import com.btljava.dao.impl.giuongnguDao;
import com.btljava.model.giuongngu;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class GiuongNguController {
    private IGiuongNguService dao;
    
    public GiuongNguController(){
        dao = new GiuongNguService();
    }

    
    public boolean insert(giuongngu gn) throws Exception {
        return dao.insert(gn);
    }

    
    public boolean update(giuongngu gn) throws Exception {
        return dao.update(gn);
    }

    
    public boolean delete(String gn) throws Exception {
        return dao.delete(gn);
    }

    
    public List<giuongngu> findAll() throws Exception {
        return dao.findAll();
    }

    
    public List<giuongngu> timkiem(String s) throws Exception {
        return dao.timkiem(s);
    }

    
    public giuongngu findbyid(int s) throws Exception {
        return dao.findbyid(s);
    }
}
