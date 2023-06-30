/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service;

import com.btljava.model.thacmac;
import java.util.List;

/**
 *
 * @author ASUS
 */
public interface IThacMacService {
    public boolean insert(thacmac tm) throws Exception;
    
    public boolean update(thacmac tm) throws Exception;
    
    public boolean delete(String tm) throws Exception;
    
    public List<thacmac> findAll() throws Exception;
    
    public List<thacmac> deleteThacMac() throws Exception;
    
    public thacmac findbyid(int s) throws Exception;
    
    public List<thacmac> timkiem(String s) throws Exception;
}
