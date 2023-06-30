/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service.Impl;

import com.btljava.Service.IDoiTuongService;
import com.btljava.daos.Idoituong;
import com.btljava.dao.impl.doituongDao;
import com.btljava.model.doituong;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class DoiTuongService implements IDoiTuongService{
    
    private Idoituong dao;
    
    public DoiTuongService(){
        dao = new doituongDao();
    }
    @Override
    public boolean insert(doituong dt) throws Exception {
        return dao.insert(dt);
    }

    @Override
    public boolean update(doituong dt) throws Exception {
        return dao.update(dt);
    }

    @Override
    public boolean delete(String id) throws Exception {
        return dao.delete(id);
    }

    @Override
    public List<doituong> findAll() throws Exception {
        return dao.findAll();
    }

    @Override
    public List<doituong> findBy(String id) throws Exception {
        return dao.findBy(id);
    }

    @Override
    public doituong findBys(int madoituong) throws Exception {
        return dao.findBys(madoituong);
    }

    @Override
    public doituong findByss(int madoituong) throws Exception {
        return dao.findByss(madoituong);
    }
    
}
