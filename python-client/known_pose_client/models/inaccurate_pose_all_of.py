# coding: utf-8

"""
    Known Pose API

    Define and retrieve (accurate) semantic poses in a 2D environment.  # noqa: E501

    The version of the OpenAPI document: 1.1.0
    Contact: Kai.Waelti@dfki.de
    Generated by: https://openapi-generator.tech
"""


import pprint
import re  # noqa: F401

import six


class InaccuratePoseAllOf(object):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    """
    Attributes:
      openapi_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    openapi_types = {
        'id': 'str',
        'taken_at': 'datetime'
    }

    attribute_map = {
        'id': 'id',
        'taken_at': 'taken_at'
    }

    def __init__(self, id=None, taken_at=None):  # noqa: E501
        """InaccuratePoseAllOf - a model defined in OpenAPI"""  # noqa: E501

        self._id = None
        self._taken_at = None
        self.discriminator = None

        self.id = id
        self.taken_at = taken_at

    @property
    def id(self):
        """Gets the id of this InaccuratePoseAllOf.  # noqa: E501


        :return: The id of this InaccuratePoseAllOf.  # noqa: E501
        :rtype: str
        """
        return self._id

    @id.setter
    def id(self, id):
        """Sets the id of this InaccuratePoseAllOf.


        :param id: The id of this InaccuratePoseAllOf.  # noqa: E501
        :type: str
        """
        if id is None:
            raise ValueError("Invalid value for `id`, must not be `None`")  # noqa: E501

        self._id = id

    @property
    def taken_at(self):
        """Gets the taken_at of this InaccuratePoseAllOf.  # noqa: E501


        :return: The taken_at of this InaccuratePoseAllOf.  # noqa: E501
        :rtype: datetime
        """
        return self._taken_at

    @taken_at.setter
    def taken_at(self, taken_at):
        """Sets the taken_at of this InaccuratePoseAllOf.


        :param taken_at: The taken_at of this InaccuratePoseAllOf.  # noqa: E501
        :type: datetime
        """
        if taken_at is None:
            raise ValueError("Invalid value for `taken_at`, must not be `None`")  # noqa: E501

        self._taken_at = taken_at

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.openapi_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, InaccuratePoseAllOf):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
