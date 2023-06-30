/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service;

import com.btljava.model.doituong;
import java.util.List;

/**
 *
 * @author ASUS
 */
public interface IDoiTuongService {
    public boolean insert(doituong dt) throws Exception;
    
    
    public boolean update(doituong dt) throws Exception;

    public boolean delete(String id) throws Exception;

    public List<doituong> findAll() throws Exception;

    public List<doituong> findBy(String id) throws Exception;
    
    
    public doituong findBys(int madoituong) throws Exception;
    
    public doituong findByss(int madoituong) throws Exception;

}
