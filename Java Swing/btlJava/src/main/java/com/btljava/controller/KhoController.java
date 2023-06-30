/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.controller;

import com.btljava.Service.IKhoService;
import com.btljava.Service.Impl.KhoService;
import com.btljava.daos.IKKho;
import com.btljava.dao.impl.khoDao;
import com.btljava.model.kho;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class KhoController {
    private IKhoService dao;
    
    public KhoController(){
        dao = new KhoService();
    }
    
    
    public boolean insert(kho kh) throws Exception {
        return dao.insert(kh);
    }

    
    public boolean update(kho kh) throws Exception {
        return dao.update(kh);
    }

    
    public boolean delete(String kh) throws Exception {
        return dao.delete(kh);
    }

    
    public List<kho> findAll() throws Exception {
        return dao.findAll();
    }

    
    public List<kho> timkiem(String s) throws Exception {
        return dao.timkiem(s);
    }

    
    public kho findAllid(int s) throws Exception {
        return dao.findAllid(s);
    }
    
    public List<kho> hienthi(int id) throws Exception{
        return dao.hienthi(id);
    }
}
