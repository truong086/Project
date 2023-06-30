/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service.Impl;

import com.btljava.Service.IKhoService;
import com.btljava.daos.IKKho;
import com.btljava.dao.impl.khoDao;
import com.btljava.model.kho;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class KhoService implements IKhoService{
    private IKKho dao;
    
    public KhoService(){
        dao = new khoDao();
    }
    
    @Override
    public boolean insert(kho kh) throws Exception {
        return dao.insert(kh);
    }

    @Override
    public boolean update(kho kh) throws Exception {
        return dao.update(kh);
    }

    @Override
    public boolean delete(String kh) throws Exception {
        return dao.delete(kh);
    }

    @Override
    public List<kho> findAll() throws Exception {
        return dao.findAll();
    }

    @Override
    public List<kho> timkiem(String s) throws Exception {
        return dao.timkiem(s);
    }

    @Override
    public kho findAllid(int s) throws Exception {
        return dao.findAllid(s);
    }

    @Override
    public List<kho> hienthi(int id) throws Exception {
        return dao.hienthi(id);
    }
    
}
